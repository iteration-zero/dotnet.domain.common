#!/bin/bash
set -ev

dotnet restore IterationZero.Domain.Common.sln
dotnet build IterationZero.Domain.Common.sln

dotnet test tests/IterationZero.Domain.Common.Tests.Unit/IterationZero.Domain.Common.Tests.Unit.csproj