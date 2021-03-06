<p align="center">
  <img src="/assets/UNiDAYS_Logo.png" />
</p>
<br/>

# UNiDAYS Contributors Guide.

:star: Thanks for taking the time to contribute :star:

This document outlines the different ways you can contribute to the UNiDAYS repositories, guidelines on how to do it and some of our standardisations. Everything is open to improvement and all of these are guidelines. If you can think of something we can change or are missing in this doc - you can even open a pull request for making that kind of change.

[Code of Conduct](CODE_OF_CONDUCT.md)

[What should I know before I get started?](#what-should-i-know-before-i-get-started)

[How Can I Contribute?](#how-can-i-contribute)
  * [Reporting Bugs](#reporting-bugs)
  * [Suggesting Enhancements](#suggesting-enhancements)
  * [Pull Requests](#pull-requests)
  * [Your First Code Contribution](#your-first-code-contribution)

[Styleguides](#styleguides)
  * [Git Commit Messages](#git-commit-messages)
  * [JavaScript Styleguide](#javascript-styleguide)
  * [CSS Styleguide](#css-styleguide)
  * [Testing Styleguide](#css-styleguide)
  * [Documentation Styleguide](#css-styleguide)

## How Can I Contribute?

### Reporting Bugs :bug:

When issuing a bug report please include as many of details on [the bug report template](bug_report.md) as possible. If you find a Closed issue that seems like it is the same thing that you're experiencing, open a new issue and include a link to the original issue in the body of your new one. Please label the any bug report issues with `bug`.

### Suggesting Enhancements 🔎

Enhancements may include completely new features and minor improvements to existing functionality. Following these guidelines helps maintainers and the community understand your suggestion and find related suggestions.

First of all please do a search on the issues already present to see if it's an enhancement that hasn't previously been suggested. If it has, maybe join the discussion on the pre-existing issue. This is to help reduce duplication of issues. If it hasn't been raised previously, please include as many details as you can using [the feature request template](feature_request.md). Label the raised feature request as `enhancement`

### Pull Requests :thought_balloon:

- Create branch. If there is an issue, have the branch name related to the linked issue, otherwise give it a descriptive name relating to what the work covers. See some examples below.

| PR-prefix       | Purpose             | Example  |
| ------------- |:----------------:| -----:|
| issuenumber_     | When it relating to a pre-existing issues | issuenumber_583 |
| enhancement      | Making things _better_ but without fixing an issue     |   enhancement_improveperformanceofquery |
| fix  | Fixing a pre-existing problem with the code that isn't an issue      | fix_acceptnullsforinput |

- Open a Pull Request with the details listed in the [pull request template](pull_request_template.md). The sections of this template should show in the body of any new pull request automatically.

- Please ensure that any changes you make comply with our [styleguides](#styleguides).

-	Include screenshots and animated GIFs in your pull request whenever possible.

- Make a comment with the pull request in any issues it relates to.

### Your First Code Contribution? :computer:

We will make efforts to label issues with `beginner` if we think they should only require a few lines of code, and a test or two. This is in order to help those who want to contribute but don't necessarily have much experience in doing so.

## Styleguides

### Git Commit Messages

We request that, where possible, you stick to the following format for your commit messages.

- Use the present tense ("Add feature" not "Added feature")
- Use the imperative mood ("Move cursor to..." not "Moves cursor to...")
- Limit the first line to 72 characters or less
- After the first line, be descriptive about what has been done in the commit.

For reference, [this blog](https://chris.beams.io/posts/git-commit/) encourages a similar style.

### JavaScript Styleguide

A full and up to date JavaScript style guide with examples can be accessed [here](https://github.com/johnnolan/StyleGuide/tree/master/Javascript).

### CSS Styleguide

A full and up to date css style guide with examples can be accessed [here](https://github.com/johnnolan/StyleGuide/tree/master/CSS).

## Testing Styleguide

In this project our tests are written using [xUnit](https://xunit.github.io/docs/getting-started-dotnet-core) and [Fluent Assertions](https://fluentassertions.com/). We would appreciate if you test cover your code using the same tooling and try to keep to a similar style that's in the project. This is to help it remain consistent and easier to maintain.

## Documentation Styleguide

For anything changing the user experience or externally visible implementation, please update the README.md as part of your pull request.

## Licencing

If it's something cool, new and funky that you are contributing, please ensure it's covered with an MIT licence.
