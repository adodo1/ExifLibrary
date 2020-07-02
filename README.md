[![License](http://img.shields.io/npm/l/xmlbuilder.svg?style=flat-square)](http://opensource.org/licenses/MIT)
[![AppVeyor](https://img.shields.io/appveyor/ci/warrengalyen/exiflibrary.svg?style=flat-square)](https://ci.appveyor.com/project/warrengalyen/exiflibrary)

ExifLibrary is a .Net Standard library for editing Exif metadata contained in image files.

# Quick Start #

To read an image file and extract metadata:

```cs
var file = ImageFile.FromFile("path_to_image");
}
// the type of the ISO speed rating tag value is unsigned short
// see documentation for tag data types
var isoTag = file.Properties.Get<ExifUShort>(ExifTag.ISOSpeedRatings);
// the flash tag's value is an enum
var flashTag = data.Properties.Get<ExifEnumProperty<Flash>>(ExifTag.Flash);
// GPS latitude is a custom type with three rational values
// representing degrees/minutes/seconds of the latitude 
var latTag = data.Properties.Get<GPSLatitudeLongitude>(ExifTag.GPSLatitude);
```

To add metadata:

```cs
var file = ImageFile.FromFile("path_to_image");
// note the explicit cast to ushort
file.Properties.Set(ExifTag.ISOSpeedRatings, <ushort>200);
```

To save the image with metadata:

```cs
file.Save("path_to_image");
```

# Documentation #

Please visit: https://warrengalyen.github.io/ExifLibrary/