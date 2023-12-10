# Architecture-Tests

Architecture tests are simple tests to write and quickly validate that your code follows the design rules you put in place.

For example, you can check:
- `Domain` layer classes don't reference other layers like `Application`.
- classes implementing `Entity` are `sealed`.
- entities have a private constructor.
- all properties on your domain entities have private setters or no setters at all. (_immutable_)
- naming convention of the types in your domain.
- etc.

Architecture tests can be applied to the entire application.

In this repository, we implement Architecture test rules using [NetArchTest.Rules](https://github.com/BenMorris/NetArchTest). This library exposes a fluent API that you can use to enforce your archi rules in unit tests.
