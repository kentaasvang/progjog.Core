#!/bin/bash

# Check if the migration name is passed as a command-line argument
if [ -z "$1" ]; then
  # If the migration name is not passed, print an error message and exit
  echo "Error: Please specify the migration name as an argument."
  exit 1
fi

# Add the new migration using the EF Core command-line tool
dotnet ef migrations add $1 --output-dir Data/Migrations --project progjog.Core/
