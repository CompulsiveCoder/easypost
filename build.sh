echo "Starting build for easy-post project"
echo "Dir: $PWD"

DIR=$PWD

xbuild src/easypost.sln /p:Configuration=Release
