<div align="center">

![Zeats](https://zeatsbalancaautomatica.blob.core.windows.net/icons/nuget.png)

</div>

# zeats-legacy-int32-extensions

Extensions to solve common problems when using Int32

[![Build Status](https://dev.azure.com/zeats/Legacy/_apis/build/status/zeats-legacy-int32-extensions?branchName=master)](https://dev.azure.com/zeats/Legacy/_build/latest?definitionId=21&branchName=master)
[![NuGet](https://img.shields.io/nuget/v/Zeats.Legacy.Int32Extensions.svg)](https://www.nuget.org/packages/Zeats.Legacy.Int32Extensions)

## Installation

```PM>
Install-Package Zeats.Legacy.Int32Extensions
```

## Extensions

### int.CastToByte()
Cast int to byte
```c#
10.CastToByte() /* return 10 (byte) */
```

### IEnumerable<int>.CastToByte()
Cast IEnumerable<int> to IEnumerable<byte>
```c#
[10, 20].CastToByte() /* return [10, 20] (bytes) */
```
---
