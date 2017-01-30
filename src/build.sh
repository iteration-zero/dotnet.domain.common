#!/bin/bash
set -ev

dotnet restore code/IterationZero.Domain.Common/IterationZero.Domain.Common.csproj
dotnet build code/IterationZero.Domain.Common/IterationZero.Domain.Common.csproj

dotnet restore tests/IterationZero.Domain.Common.Tests.Unit/IterationZero.Domain.Common.Tests.Unit.csproj
dotnet build tests/IterationZero.Domain.Common.Tests.Unit/IterationZero.Domain.Common.Tests.Unit.csproj

dotnet test tests/IterationZero.Domain.Common.Tests.Unit/IterationZero.Domain.Common.Tests.Unit.csproj