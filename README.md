# Scenographer

[![Build](https://github.com/scenographer/scenographer-dotnet/actions/workflows/ci.yml/badge.svg)](https://github.com/scenographer/scenographer-dotnet/actions/workflows/ci.yml)

WebExtension for Playwright for .NET

## API Reference

```csharp
using Microsoft.Playwright;
using Scenographer;

// Installing AdBlock
// https://chrome.google.com/webstore/detail/gighmmpiobklfepjocnamgkkbiglidom

await BrowserStorage.Default
    .UseFeed(WebStore.Chrome)
    .InstallExtensionAsync("gighmmpiobklfepjocnamgkkbiglidom");

var options = new BrowserTypeLaunchPersistentContextOptions().UseWebExtensions();

using var playwright = await Playwright.CreateAsync();
await using var browser = await playwright.Chromium.LaunchPersistentContextAsync(BrowserStorage.Default.BaseDirectory, options);

var page = browser.Pages[0];
await page.GotoAsync("chrome://extensions");
```
