@echo off

echo Publish project...
dotnet publish Academy.Tutorial.GuessingGame.Game.csproj -o bin/Publish -c Release

echo Build image
docker build -t guessing-game:1.0 .

echo Tag latest image
docker tag guessing-game:1.0 guessing-game:latest

echo Completed