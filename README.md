# tests

Small C# console exercises, each in its own project.

## Projects

- **bubbling** — bubble sort; `largestNumber` sorts an array and returns its max.
- **t1** — reads a line from stdin and echoes it back.
- **largestNumber** — returns the largest of four integers.

## Running

Each project targets `net10.0` and uses the modern SDK-style `.csproj`, so it runs with the `dotnet` CLI:

```
cd <project>/<project>
dotnet run
```

For example:

```
cd bubbling/bubbling
dotnet run
```

## Notes

- `numberWizard.cs` (repo root) is a Unity `MonoBehaviour` script, not a standalone console project. It depends on Unity's engine (`UnityEngine.Input`, the `Update()` game loop) and can only be run inside a Unity Editor project, not via `dotnet run`.
