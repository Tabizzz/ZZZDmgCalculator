#!/usr/bin/env bash

dnf install -y wget libatomic1
wget https://dot.net/v1/dotnet-install.sh -O dotnet-install.sh
chmod +x ./dotnet-install.sh 
./dotnet-install.sh
export PATH="$PATH:/vercel/.dotnet"
dotnet workload install wasm-tools