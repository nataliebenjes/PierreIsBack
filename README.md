# ** **Pierre's bakery**

### By Natalie Benjes

Welcome to Pierre's Sweet and Savory Treats application. This project aims to provide a user-friendly experience by
allowing users to explore a variety of treats and flavors. Users can register, log in, and interact with the treats and
flavors in a secure and straightforward manner. This README will guide you through the setup and understanding of the
project.


## Technologies used
- HTML
- CSS
- C#
- .NET 6.0
- MySQL Workbench
- SQL Database
- AspNetCore
- Entity Framework
- Linq
- Mvc

## Complete setup/installation instructions
- Clone this repository from GitHub
- Navigate to the Bakery directory in your terminal and create a new file called appsettings.json
- Within this file add the following lines of code:

```
{
"ConnectionStrings": {
"DefaultConnection": "Server=localhost;Port=3306;database=natalie_benjes;uid=root;pwd=epicodus;"
}
}
```

- Once this has been set up, navigate to the Bakery directory and run ```dotnet ef database update``` & ```dotnet watch run```


## Known Bugs

## License
MIT

Copyright (c) 2023 Natalie Benjes

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated
documentation files (the “Software”), to deal in the Software without restriction, including without limitation the
rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit
persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the
Software.

THE SOFTWARE IS PROVIDED “AS IS”, WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR
OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE

