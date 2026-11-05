# AGENTS.md - Leave MAnagementSystem
## Purpose
This repository is an ASP.NET Core MVC Leave MAangement System using EF Core , Sql server, agents must preserve the layered 
architecture and modernize toward .NET 10.

##Set up commands
use these commands from the repository root:
```bash
dotnet --Info
dotnet restore LeaveManagementSystem.sln
dotnet build LeaveManagementSystem.sln --configuration Release --no-restore
dotnet test LeaveManagementSystem.sln --configuration Release --no-build
```