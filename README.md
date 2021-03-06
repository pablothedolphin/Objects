# Objects

[![Twitter Follow](https://img.shields.io/twitter/follow/SpeckleSystems?style=social)](https://twitter.com/SpeckleSystems) [![Discourse users](https://img.shields.io/discourse/users?server=https%3A%2F%2Fdiscourse.speckle.works&style=flat-square)](https://discourse.speckle.works)
[![Slack Invite](https://img.shields.io/badge/-slack-grey?style=flat-square&logo=slack)](https://speckle-works.slack.com/join/shared_invite/enQtNjY5Mzk2NTYxNTA4LTU4MWI5ZjdhMjFmMTIxZDIzOTAzMzRmMTZhY2QxMmM1ZjVmNzJmZGMzMDVlZmJjYWQxYWU0MWJkYmY3N2JjNGI) [![website](https://img.shields.io/badge/www-speckle.systems-royalblue?style=flat-square)](https://speckle.systems)

**Status**

![.NET Core](https://github.com/specklesystems/Objects/workflows/.NET%20Core/badge.svg)

## Disclaimer
This is an early alpha release, not meant for use in production! We're working to stabilise the 2.0 API, and until then there will be breaking changes. You have been warned!

## Introduction

Before venturing any further please make sure to check the following: 

- [Code of Conduct](CODE_OF_CONDUCT.md), 
- [Contribution Guidelines](CONTRIBUTING.md), 
- [License](LICENSE)

### Objects

The Speckle 2.0 object model: geometry and element base classes. It uses .NET Standard 2.0 and has been tested on Windows and MacOS.

**NOTE:** this is the default object model we ship with Speckle. You can develop your own or fork this and extend it too!

More info on Objects and Kits 2.0 can be found in [this community forum thread](https://discourse.speckle.works/t/introducing-kits-2-0/710/34).

## Developing & Debugging

### Building

Just restore all the NuGet packages and hit Build!

### Developing

Objects is just a set of Data Transfer Objects, it's quite straightforward to understand how they work!

#### Host application support

In order to better support interop between the various AEC host applications and Speckle, Objects also contains classes that help to deal with native object types and their properties.

For example, you'll see a `\Revit` folder. That contains a series of classes that extend the basic ones with a series of default Revit properties. This is the approach we'll follow with other host applications as well.

## Contributing

Please make sure you read the [contribution guidelines](CONTRIBUTING.md) for an overview of the best practices we try to follow.

## Community 

The Speckle Community hangs out in two main places, usually: 

- on [the forum](https://discourse.speckle.works)
- on [the chat](https://speckle-works.slack.com/join/shared_invite/enQtNjY5Mzk2NTYxNTA4LTU4MWI5ZjdhMjFmMTIxZDIzOTAzMzRmMTZhY2QxMmM1ZjVmNzJmZGMzMDVlZmJjYWQxYWU0MWJkYmY3N2JjNGI) 

Do join and introduce yourself! 

## License

Unless otherwise described, the code in this repository is licensed under the Apache-2.0 license.
