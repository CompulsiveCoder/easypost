BRANCH=$1

if [ -z "$BRANCH" ]; then
    BRANCH=$(git branch | sed -n -e 's/^\* \(.*\)/\1/p')
fi

if [ -z "$BRANCH" ]; then
    BRANCH="master"
fi

echo "Branch: $BRANCH"

TMP_DIR="_tmp/easypost"

if [ -d "$TMP_DIR" ]; then
    rm $TMP_DIR -rf
fi

git clone https://github.com/CompulsiveCoder/easypost.git $TMP_DIR --branch $BRANCH
cd $TMP_DIR

sh init-build-test.sh
