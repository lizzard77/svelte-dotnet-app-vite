# .NET + Svelte + Vite

This template will boost your experience when developing apps with a .NET backend 
and Svelte + Vite frontend while still staying VERY lightweight and slim.

## .NET6 vs. .NET7 Considerations

On computers where .NET7 is installed, it might be necessary to force the target framework 
to .NET6 when using this template. That way, you will be able to stay on .NET6 (which is the 
LTS version of .NET). For this purpose, `global.json` is now included in the root folder.

If you prefer to use .NET7, change the line with the target framework moniker in `svelte-dotnet-app-vite.csproj` 
to 

`<TargetFramework>net6.0</TargetFramework>`

and delete `global.json`.

## Recommended IDE Setup

[VS Code](https://code.visualstudio.com/) + [Svelte Extension/Language Service](https://marketplace.visualstudio.com/items?itemName=svelte.svelte-vscode).

