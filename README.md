# NuSpec.ReferenceGenerator Sample

This repository contains a sample solution for using [NuSpec.ReferenceGenerator](https://github.com/onovotny/ReferenceGenerator) to create your NuSpec files. But be aware that this sample only shows the points where the tooling is currently failing. **Do not** expect this to be a fully working sample.

The NuSpec files under the solution directory are minimal files in which the NuSpec.ReferenceGenerator tool adds dependencies. More complete NuSpec files and packages are available under the NuGetFiles folder.

The NuGet consumer project fails on a .rd.xml duplicate file, which is reported to the Microsoft team. If you want to test this project, you'll have to self-host the test packages found under the NuGetFiles folder.

Blog post: http://www.bartlannoeye.com/blog/creating-nuget-packages-for-your-windows-10-uwp-libraries