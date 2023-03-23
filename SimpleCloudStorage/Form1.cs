using Azure;
using Azure.Identity;
using Azure.Storage.Blobs;
using Azure.Storage.Blobs.Models;

namespace SimpleCloudStorage
{
    public partial class Form1 : Form
    {
        BlobServiceClient client;
        public Form1()
        {
            InitializeComponent();
            //blobServiceClient = new BlobServiceClient("DefaultEndpointsProtocol=https;AccountName=sasimplestorage6;AccountKey=iMBS2+vndpXs7PYYuCs+NQUu+1A690LUWbceJG5DVI3rR2PcKZGGCTZCoM0IGxI02WbUUXj5W3LK+ASt7EX5Kg==;EndpointSuffix=core.windows.net");
            client = new(new Uri("https://sasimplestorage6.blob.core.windows.net"), new DefaultAzureCredential());
        }

        private async void btnLoad_Click(object sender, EventArgs e)
        {
            
            Console.WriteLine("Containers:");
            await foreach (BlobContainerItem container in client.GetBlobContainersAsync())
            {
                lbxContainer.Items.Add(container.Name);
            }
            //string containerName = "files";
            //BlobContainerClient containerclient = blobServiceClient.GetBlobContainerClient("files");

            //await foreach(BlobItem blob in containerclient.GetBlobsAsync())
            //{
            //    Console.WriteLine($"* {blob.Name}");
            //}
            //string blobName = "Untitled-1.http";
            //Console.Write($"Donwloading {blobName}");
            
            //try
            //{

            //    BlobClient blobClient = containerclient.GetBlobClient(blobName);
            //    await blobClient.DownloadToAsync("tasklist.http");
            //    Console.ForegroundColor = ConsoleColor.Green;
            //    Console.Write("Done.");
            //    Console.ResetColor();
            //}
            //catch (RequestFailedException ex)
            //{
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("Error: ");
            //}
        }

        private async void lbxContainer_Click(object sender, EventArgs e)
        {
            
            BlobContainerClient containerclient = client.GetBlobContainerClient(lbxContainer.SelectedItem.ToString());

            await foreach (BlobItem blob in containerclient.GetBlobsAsync())
            {
                lbxBlobs.Items.Add(blob.Name);
            }
            
        }

        private async void btnDownload_Click(object sender, EventArgs e)
        {
            try
            {
                BlobContainerClient containerclient = client.GetBlobContainerClient(lbxContainer.SelectedItem.ToString());
                BlobClient blobClient = containerclient.GetBlobClient(lbxBlobs.SelectedItem.ToString());
                await blobClient.DownloadToAsync(lbxBlobs.SelectedItem.ToString());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Done.");
                Console.ResetColor();
            }
            catch (RequestFailedException ex)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error: ");
            }
        }
    }
}
