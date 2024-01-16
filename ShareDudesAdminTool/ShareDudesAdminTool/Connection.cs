using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

public class Connection
{
    private async void connection()
    {
        string url = "https://example.com/api/data"; // Ändern Sie dies entsprechend Ihrer API-URL

        using (HttpClient client = new HttpClient())
        {
            try
            {
                HttpResponseMessage response = await client.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    string responseData = await response.Content.ReadAsStringAsync();
                    // Hier können Sie mit den Daten arbeiten, z.B. in Ihren Steuerelementen anzeigen
                    MessageBox.Show("Erfolgreiche Antwort: " + responseData);
                }
                else
                {
                    MessageBox.Show("Fehler beim HTTP-Request: " + response.ReasonPhrase);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fehler: " + ex.Message);
            }
        }
    }
}

