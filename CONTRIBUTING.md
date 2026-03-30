# Contributing

Contributions to this project are [released](https://help.github.com/articles/github-terms-of-service/#6-contributions-under-repository-license) to the public under the [project's open source license](LICENSE).

Everyone is welcome to contribute to this project. Contributing doesn't just mean submitting pull requests—there are many different ways for you to get involved, including answering questions, reporting issues, improving documentation, or suggesting new features.

## How to Contribute

### Reporting Issues

If you find a bug or have a feature request:
1. Check if the issue already exists in the [GitHub Issues](https://github.com/orassayag/cv-spider-v3/issues)
2. If not, create a new issue with:
   - Clear title and description
   - Steps to reproduce (for bugs)
   - Expected vs actual behavior
   - Your environment details (OS, .NET version, SQL Server version)

### Submitting Pull Requests

1. Fork the repository
2. Create a new branch for your feature/fix:
   ```bash
   git checkout -b feature/your-feature-name
   ```
3. Make your changes following the code style guidelines below
4. Test your changes thoroughly
5. Commit with clear, descriptive messages
6. Push to your fork and submit a pull request

### Code Style Guidelines

This project uses:
- **C#** with ASP.NET Web Forms
- **SQL Server** with stored procedures
- **.NET Framework** conventions

Before submitting:
```bash
# Build the solution
# Open Visual Studio and build the solution (Ctrl+Shift+B)

# Test the application
# Run the application locally and verify functionality
```

### Coding Standards

1. **Naming conventions**: Use PascalCase for methods, camelCase for local variables
2. **Error handling**: Use try-catch blocks for external operations (web requests, database)
3. **Code organization**: Keep related functionality in separate classes
4. **Database operations**: Use parameterized queries and stored procedures
5. **Email validation**: Ensure robust validation before storing
6. **Comments**: Add comments for complex logic and regex patterns

### Adding New Features

When adding new features:
1. Create appropriate classes in `Core/` directory for business logic
2. Add stored procedures for database operations
3. Update DAL (Data Access Layer) and BLL (Business Logic Layer)
4. Test with various edge cases
5. Update documentation

### Database Changes

When modifying the database:
1. Create stored procedures rather than inline SQL
2. Use proper parameter types and validation
3. Test with various inputs
4. Document the purpose and parameters

## Ethical Considerations

**IMPORTANT**: This project is for educational and research purposes only. When contributing:
- Respect robots.txt files and website terms of service
- Implement rate limiting to avoid overwhelming servers
- Do not use for spam or unsolicited commercial messages
- Ensure compliance with anti-spam laws (CAN-SPAM, GDPR, etc.)
- Respect privacy and data protection regulations

## Questions or Need Help?

Please feel free to contact me with any question, comment, pull-request, issue, or any other thing you have in mind.

* Or Assayag <orassayag@gmail.com>
* GitHub: https://github.com/orassayag
* StackOverflow: https://stackoverflow.com/users/4442606/or-assayag?tab=profile
* LinkedIn: https://linkedin.com/in/orassayag

Thank you for contributing! 🙏
