# 🆕 My Project

## ❓ What is My Project?

## ⚡ Getting Started

## 🔧 Building and Running

**initiate user-secrets**
```shell
dotnet user-secrets init --project progjog.Core/
dotnet user-secrets set "Database:ConnectionString" "Database:ConnectionString = Server=localhost;Port=3306;Database=progjog_db;Userid=root;Password=password;" --project progjog.Core/
# to list all secrets
dotnet user-secrets list --project progjog.Core/
# to remove a secret
dotnet user-secrets remove "Database:Name" --project progjog.Core/
```


### 🔨 Build the Project

### ▶ Running and Settings

## 🤝 Collaborate with My Project
