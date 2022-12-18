# 🆕 ProgJog

## ❓ What it is
Simple website where you can create and/or browse though training plans.

[//]: # (## ⚡ Getting Started)

## 🔧 Building and Running for Local Development

### 🔨 Build the Project
```shell
dotnet build --project progjog.Core
```

### ▶ Running and Settings

**Initiate user-secrets and configure settings**
```shell
dotnet user-secrets init --project progjog.Core/
dotnet user-secrets set "Database:ConnectionString" "Database:ConnectionString = Server=localhost;Port=3306;Database=progjog_db;Userid=root;Password=password;" --project progjog.Core/
# to list all secrets
dotnet user-secrets list --project progjog.Core/
# to remove a secret
dotnet user-secrets remove "Database:Name" --project progjog.Core/
```

**Run docker-compose for dev db**
```shell
docker-compose up -d 
```

**Run migrations if new Db**
```shell
./update_dev_db.sh
```

**Running**
```shell
dotnet run --project progjog.Core/
```

## 🤝 Collaborate with My Project
No one can stop you.