#!/usr/bin/env bash

dnf install -y wget
wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
chmod +x ./dotnet-install.sh 
./dotnet-install.sh