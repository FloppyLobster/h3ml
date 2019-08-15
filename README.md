# H3ML - Hyper 3D Markup Language

Html with css has been the latest driving force in the democratization of information. However the unsung hero is the unseen html layout engine. Prior to a layout engine, content creation was a laborious task. A content creator utilized a page layout tool like Adobe PageMaker. PageMaker helped with kerning, flowing text around images, formatting, and indenting, and would result in a rasterized image, which could be distributed.

Hyper 3D markup language, or h3ml, extends content from 2D to 3D processing, with all the same html and css syntax. 

H3ml has no focus on 3D model generation. Similar to referencing images, model are represented in a single element with attributes to describe them. An asset provider translates attribute values to a 3D model with its textures and properties. The 3D models are instanciated using the `<obj>` tag, whose self and properties are sourced from the Asset Provider.

For example if you representing a car:
```
<obj abc:cref="car" make="ford" doors="4" color="red" />
```

# Asset provider
The asset provider is registered with H3ML and will instanciate the object. Because of this, outside of simply browsing the internet, one needs a way to preview the assets being created. 

# Asset studio
This is a stripped-down website used for previewing objects being built.

# Source Code

This repository holds the implementation of h3ml engine in C#.

# Table of Contents

## Browser.Forms
Sample implementation of a browser using H3ML, only in 2D
## H3ML
Layout Engine
## H3ML.Cairo
Cairo support for H3ML. Cairo is a low-level 2D rendering engine primarily used for fonts.
## H3ML.Script
Provides Javascript used in Google's V8 engine
## H3ML.Script.Tests
Tests to exercise the Javascript
## H3ML.Tests
Tests to exercise the H3ML layout engine
## H3ML.Windows.Forms
A Windows form renderer for the H3ML engine. Used by Browser.Forms
## lite.html
Reference source

# Author

The author of this library is [Sky Morey](https://www.linkedin.com/in/sky-morey/).
