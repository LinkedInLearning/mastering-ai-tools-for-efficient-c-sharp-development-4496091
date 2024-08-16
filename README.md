# Mastering AI Tools for Efficient C# Development

This is the repository for the LinkedIn Learning course **Mastering AI Tools for Efficient C# Development**.

![lil-thumbnail-url]

<p>Discover the innovative intersection of artificial intelligence (AI) with coding and technical writing. This course is designed to help enhance and streamline your software development and documentation processes. First, explore AI autocomplete tools, with a focus on GitHub Copilot. Learn about its installation, customization, and practical use for code completion, refactoring, and cleanup. Then, find out how to harness AI to improve your technical writing skills, using tools like GitHub Copilot and ChatGPT to create documentation and tutorials. Join Jesse Freeman who provides practical insights and hands-on examples to empower you with the confidence and skills needed to start using AI tools effectively.</p>

This repository contains the code generated by AI during the course. The primary goal is to demonstrate the type of code that AI can generate and to provide accompanying documentation. This is a companion to the main course.

_See the readme file in the main branch for updated instructions and information._

## Instructions

This repository has branches for each of the lessons in the course. You can use the branch pop-up menu in GitHub to switch to a specific branch and take a look at the course at that stage, or you can add `/tree/BRANCH_NAME` to the URL to go to the branch you want to access.

## Branches

The branches are structured to correspond to the lessons in the course. The naming convention is `lesson-CHAPTER.MOVIE`. For example, the branch named `lesson-1.2` corresponds to Chapter 1, Lesson 2.

### Example Branch List

- `lesson-1.3`
- `lesson-1.4`
- `lesson-2.2`
- `lesson-2.3`

The `main` branch holds the final state of the code as presented at the end of the course.

When switching from one exercise files branch to the next after making changes to the files, you may get a message like this:

    error: Your local changes to the following files would be overwritten by checkout: [files]
    Please commit your changes or stash them before you switch branches.
    Aborting

To resolve this issue:
	
    Add changes to git using this command: git add .
	Commit changes using this command: git commit -m "some message"

## Installing

1. To use these exercise files, you must have the following installed:
	- Visual Studio Code
	- .NET 7 SDK
	- Git
	- GitHub Copilot extension for Visual Studio Code

2. Clone this repository into your local machine using the terminal (Mac, Linux) or CMD (Windows).

    ```sh
    git clone https://github.com/yourusername/your-repo-name.git
    ```

3. Navigate to the project directory.

    ```sh
    cd your-repo-name
    ```

4. Open the project in Visual Studio Code.

    ```sh
    code .
    ```

5. Restore the .NET packages:

    ```sh
    dotnet restore
    ```

6. Build and run the project:

    ```sh
    dotnet run
    ```


### Instructor

Jesse Freeman

Head of Partner and Framework Marketing at Amazon
                 

Check out my other courses on [LinkedIn Learning](https://www.linkedin.com/learning/instructors/jesse-freeman?u=104).

[0]: # (Replace these placeholder URLs with actual course URLs)

[lil-course-url]: https://www.linkedin.com/learning/mastering-ai-tools-for-efficient-c-sharp-development
[lil-thumbnail-url]: https://media.licdn.com/dms/image/v2/D4E0DAQHIUZH6xqAasQ/learning-public-crop_675_1200/learning-public-crop_675_1200/0/1723574020710?e=2147483647&v=beta&t=uLo-GWBvIaN6XA0uJLKV6xhulHXGLrypiz5crArO64c
