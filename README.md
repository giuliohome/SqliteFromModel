[![Open Source Love](https://badges.frapsoft.com/os/v3/open-source.svg?v=103)](https://github.com/ellerbrock/open-source-badges/)
![License](https://img.shields.io/badge/License-Apache%202.0-blue.svg)

# SqliteFromModel
Model First Approach in F# with SQLite

## Problem

F# SQL Type Provider is based on the assumption that a table already exists before writing code.
This is not avoiding boilerplate code but losing a feature

## Solution

The simple console program shows an [utility](https://github.com/giuliohome/SqliteFromModel/blob/master/Program.fs#L12) to create SQLite tables from their Model types, with Linq2DB mapping annotations.

