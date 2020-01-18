# csharp-nullable-weird-behavior

A "bug" that I found on C#8 feature, weird behavior, the message should be much more explicit

## Description

The compiler will output
```
Class1.cs(19, 30): [CS0121] The call is ambiguous between the following methods or properties: 'IGenericAsyncRepository<TObject, TObjectId>.SaveAsync(TObject)' and 'IGenericAsyncRepository<TObject, TObjectId>.SaveAsync(TObject)'
```

Which is not developer friendly (took me several hours to figure out what is the cause of that)

## How to reproduce

Create a set of 4 project (maybe less can be enough but I already spent much time on this)

- ProjectA
  - Nullable: true
- ProjectB
  - Nullable: false
  - Referencing:
    - ProjectA
- ProjectC
  - Nullable: false
  - Referencing:
    - ProjectA
    - ProjectB
- ProjectD (**the one with the weird compiler output**)
  - Nullable: false
  - Referencing:
    - ProjectB
    - ProjectC
