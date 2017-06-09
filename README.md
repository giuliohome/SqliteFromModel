# SqliteFromModel
Model First Approach in F# with SQLite

## Problem

F# SQL Type Provider is based on the assumption that a table already exists before writing code.
So this is not avoiding boilerplates but losing a feature

## Solution

This is an utility to create SQLite tables from their Model types, with Linq2DB mapping annotations.

