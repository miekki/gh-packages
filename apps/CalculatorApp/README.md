to be able to restore depenedinces from GitHub Packages you need too

1. Create a PAT (personal Access Token) with permissions to read the githb packages
2. Run below command and update before running
   - ORG_NAME - your github orgranization name
   - YOUR_PAT - your GitHub PAT generated earlier

dotnet nuget add source --username ORG_NAME --store-password-in-clear-text --password YOUR_PAT --name github https://nuget.pkg.github.com/ORG_NAME/index.json
