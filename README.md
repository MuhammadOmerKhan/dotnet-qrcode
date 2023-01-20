# Installation
To use QRCoder in your .NET 6.0 project, you can install it via NuGet package manager by running the following command in the Package Manager Console:

```C#
PM> NuGet\Install-Package QRCoder -Version 1.4.1
```

# Usage
Here's an example of how to use QRCoder to generate a QR code:

```C#
using QRCoder;

// Generate QR code
string data = "Hello, QR code!";
QRCodeGenerator qrGenerator = new QRCodeGenerator();
QRCodeData qrCodeData = qrGenerator.CreateQrCode(data, QRCodeGenerator.ECCLevel.Q);
QRCode qrCode = new QRCode(qrCodeData);

// Save QR code as PNG
using (Bitmap qrCodeAsBitmap = qrCode.GetGraphic(20))
{
    qrCodeAsBitmap.Save("qrcode.png", ImageFormat.Png);
}
```

# Conclusion
This will create a QR code with the data "Hello, QR code!" and save it as a PNG image file called "qrcode.png" in the current directory.
