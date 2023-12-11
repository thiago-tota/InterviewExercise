# TaskManager

This is a C# project.

- You have <b>30 minutes</b> time to write/implement the requirements below.
- If you have any questions you are allowed to ask

# Pre setup

Following user exist in your application the number followed by `#` is the id of the user.

```
#1 John Smith
#2 Alice Johnson
#3 Robert Williams
#4 Emily Davis
```

Only above users exist, because the [ExamplesApi](External/ExamplesApi.cs) will
return you data only for those users. Data is defined here: [examples.json](External/Resources/examples.json)

## Requirements

### Task 1 - Create an InputOutputManager

Direct access to the console (e.g. `WriteLine` and `ReadLine`) should not take place, but rather access to methods of an InputOutputManager.
In addition, an unit test must be created for the InputOutputManager.

### Task 2 - Make sure the application runs continuously

The application must run continuously (as many times as desired) until explicitly requested to quit.

### Task 3 - An User wants to see (via the Console) which tasks are assigned to him

Hereby the user wants to see the state of his tasks. Note: You may want to use
the [ExamplesApi](External/ExamplesApi.cs).

- To Do
- In Progress
- Done

You can use following template to show the details in the `Console`

```
####################
The following tasks are assigned to you:

To Do: [..., ..., ...,]
In Progress: [..., ..., ...,]
Done: [..., ..., ...,]
####################
```
