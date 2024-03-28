<?php
//https://xxxxxx.com/backup.php?ignore={%22file%22:[%22backup.php%22],%22dir%22:[%22.well-known%22,%22backup%22,%22cdn%22]}&backupfolder=backup&type=cores
function Directory($directory)
{
    $subDirs = [];
    if (is_dir($directory)) {
        $iterator = new DirectoryIterator($directory);
        foreach ($iterator as $fileInfo) {
            if ($fileInfo->isDir() && !$fileInfo->isDot()) {
                if (($fileInfo->getFilename() != "acme-challenge") && ($fileInfo->getFilename() != ".well-known")) {
                    // Alt klasörleri $subDirs dizisine ekle
                    $subDirs[] = $fileInfo->getFilename();
                }
            }
        }
    }
    return $subDirs;
}

function BackupZip($backupSource, $source, $ignore)
{
    $files = new RecursiveIteratorIterator(
        new RecursiveDirectoryIterator($source, RecursiveDirectoryIterator::SKIP_DOTS),
        RecursiveIteratorIterator::SELF_FIRST
    );

    $zip = new ZipArchive();
    $zip->open($backupSource, ZipArchive::CREATE | ZipArchive::OVERWRITE);
    foreach ($files as $file) {
        $filePath = $file->getRealPath();
        $relativePath = substr($filePath, strlen($source) + 1);

        $ignore = @json_decode($ignore, true);
        $ignoreFiles = $ignore["file"];
        $ignoreDirectories = $ignore["dir"];
        $pathParts = explode('/', $relativePath);

        $ignoreFile = @in_array(end($pathParts), $ignoreFiles);
        $ignoreDirectory = @in_array($pathParts[0], $ignoreDirectories);

        if ($ignoreFile || $ignoreDirectory) {
            continue;
        }

        if ($file->isDir()) {
            $zip->addEmptyDir($relativePath);
        } else {
            $zip->addFromString($relativePath, file_get_contents($filePath));
        }
    }
    $zip->close();
}

header("Content-Type: application/json");
$key = htmlspecialchars($_GET['key'], ENT_QUOTES, 'UTF-8');
$type = htmlspecialchars($_GET['type'], ENT_QUOTES, 'UTF-8');
$backupFolder = htmlspecialchars($_GET['backupfolder'], ENT_QUOTES, 'UTF-8');
$secureKey = "securekey12345";
if($key == "" || $key != $secureKey){
    print_r(json_encode(['statu' => 'error', 'result' => 'secure key error'], true));
    exit();
}

$ignore = $_GET['ignore'];
if ($type == "dir") {
    $directory = __DIR__;
    $arr = [];
    if (is_dir($directory)) {
        $iterator = new DirectoryIterator($directory);

        foreach ($iterator as $fileInfo) {
            if ($fileInfo->isDir() && !$fileInfo->isDot()) {
                $a = false;
                foreach (json_decode($ignore, true)["dir"] as $item) {
                    if ($fileInfo->getFilename() == $item) {
                        $a = true;
                        break;
                    }
                }
                if ($a == false)
                    $arr[] = $fileInfo->getFilename();

            }
        }
    }
    print_r(json_encode($arr, true));
} else {

    if ($backupFolder == "") {
        print_r(json_encode(['statu' => 'error', 'result' => 'backup folder source not found'], true));
        exit();
    }
    if (!file_exists($backupFolder)) {
        mkdir($backupFolder, 0777, true);
    }
    $versionTime = $type . "-" . time() . '.zip';
    if ($type != "") {
        $type = "/" . $type;
    } else {
        print_r(json_encode(['statu' => 'error', 'result' => 'source folder empty'], true));
        exit();
    }
    $source = __DIR__ . $type;
    $backupSource = './' . $backupFolder . '/' . $versionTime;
    if (!file_exists($source)) {
        print_r(json_encode(['statu' => 'error', 'result' => 'source folder not found'], true));
        exit();
    }
    BackupZip($backupSource, $source, $ignore);
    print_r(json_encode(['statu' => 'success', 'result' => $versionTime], true));
}
?>

