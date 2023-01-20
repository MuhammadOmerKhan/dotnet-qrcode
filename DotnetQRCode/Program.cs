using QRCoder;
using System.Drawing;
using System.Drawing.Imaging;

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