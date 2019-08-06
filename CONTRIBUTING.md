# Contributing to NEO
Neo is an open-source project and it depends on its contributors to create new features and apply fixes. You are more than welcome to join us in the development of Neo.  

## Questions and Support
The issue list is reserved exclusively for bug reports and features discussions. If you have questions or need support, instead of creating an issue, please use our [Discord](https://discord.io/neo) server.

## Developer Workflow
We have decided to create simple rules for our development workflow, to keep our GitHub organized with issues with well-defined goals.  
It is important that developers follow this workflow in order to keep development efficient and transparent.

![./.github/workflow.png]()

1. Before you submit a PR, ensure that you have an issue created.
   1. Use a descriptive titles and descriptions in your PRs. They may be used in our monthly report.  
2. Proposals must be discussed before being implemented. Proposals with `discussion` tags are still in the discussion phase.  `design` tags are used when the issue is in the design phase.
3. When the team reaches about the solution, the tags `discussion` and `design` are replaced with `ready-to-implement`.   
   1. In certain cases, a milestone can be added.
4. Reviewers must test the issue before approving it.  
   1. Even if the code has been approved, you should leave at least 24 hours for others to review it. 
5. Developers may merge code if the issue was reviewed by at least 2 developers and 24 hours have passed since the last review.  
6. Issues with `trivial` tag are excluded from the reward program.  
7. Make sure you run `dotnet format` before sending your PR.  
8. All features and fixes must be tested, so at least one Unit Test is required for every PR.  
9.  If developers want to work in a specific issue, he may ask the team to assign it to himself.
    1.  We suggest the developer to finish his work in up to 14 days after the task is assigned, in order to avoid the project to 'freeze'.
    2.  The proposer of an issue has priority in task assignment.


### Messages Guidelines
We recommend you follow this guidelince, since the content you provide in your PRs and commits may be used in our monthly meeting. Please use descriptive titles and sub-titles (in both PRs and commits).  
The file format we suggest is `module-title-subtitle`. Examples:  
- `persistence - rocksdb - Replacing LevelDB with RocksDB`;
- `network - ProtocolHandler - Adding mempool flush methods`;

We don't have a pre-defined list of modules. You are free to choose one that makes sense for you.

If your are reverting changes, please use the following format:
- `revert - 'commit hash'`
- `revert - '#PR'` 
   
###

