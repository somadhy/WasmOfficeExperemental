# Пример подключения Aspose.Cells в WASM
Тулинг

```ps
dotnet workload install wasm-tools
```

Добавление Aspose.Cells в WASM проект

```ps
dotnet add package Aspose.Cells --version 18.11.0 # Не работает
dotnet remove package Aspose.Cells
dotnet add package Aspose.Cells --version 23.10.0 # Работает
```

## Запуск 

Публикация сборки

```ps
dotnet publish --configuration Release
```

А дальше подмонтировать `.\bin\Release\net8.0\wwwroot` к любому Web серверу, например IIS. Да хоть Питоном 

```bash
python3 -m http.server -d ".\bin\Release\net8.0\publish\wwwroot" 8000
```

И открыть `http://localhost:8000/index.html`