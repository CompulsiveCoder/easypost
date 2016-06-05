CATEGORY=$1

if [ -z "$CATEGORY" ]; then
    CATEGORY="Unit"
fi

echo "Testing easy-post project"
echo "Dir: $PWD"
echo "Category: $CATEGORY"


mono lib/NUnit.Runners.2.6.4/tools/nunit-console.exe bin/Release/easypost.*.dll --include=$CATEGORY
