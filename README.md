# SqliteFromModel
Model First Approach in F# with SQLite

## Problem

F# SQL Type Provider is based on the assumption that a table already exists before writing code.
This is not avoiding boilerplate code but losing a feature

## Solution

The simple console program shows an utility to create SQLite tables from their Model types, with Linq2DB mapping annotations.

