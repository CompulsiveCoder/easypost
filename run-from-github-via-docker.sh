BRANCH=$1

if [ -z "$BRANCH" ]; then
    BRANCH=$(git branch | sed -n -e 's/^\* \(.*\)/\1/p')
fi

if [ -z "$BRANCH" ]; then
    BRANCH="master"
fi

echo "Branch: $BRANCH"

docker run -d -p 8088:8088 compulsivecoder/ubuntu-mono /bin/bash -c "curl https://raw.githubusercontent.com/CompulsiveCoder/easypost/$BRANCH/run-from-github.sh | sh -s $BRANCH"
