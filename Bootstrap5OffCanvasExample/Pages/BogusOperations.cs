using Bootstrap5OffCanvasExample.Classes;

namespace Bootstrap5OffCanvasExample.Pages;

public class BogusOperations
{
    public static List<Sentence> MainSentences()
    {
        var list = new List<Sentence>();
        var dataSet = new Bogus.DataSets.Lorem();
        for (int index = 0; index < 10; index++)
        {
            list.Add(new Sentence() {Text = dataSet.Sentence(100) });
        }

        return list;
    }

    public static List<Sentence> NoticeSentences() =>
        new()
        {
            new Sentence() {Text = "Call volumes are currently higher than normal. If you have trouble getting through by phone, please use the Online Claim System, the automated Weekly Claim Line at 800-982-8920, or use the Contact Us form to send us questions and information. If you need to call, try again later today or later this week.\u200b"},
            new Sentence() {Text = "Actualmente, el volumen de llamadas es superior a lo normal. Si tiene problemas para comunicarse por teléfono, utilice el Sistema de reclamos en línea, la Línea de reclamo semanal automatizada al 800-982-8920 o use el formulario Contáctenos para enviarnos preguntas e información. Si necesita llamar, inténtelo nuevamente más tarde hoy o esta semana. \u200b\u200b"},
            new Sentence() {Text = "Frances Online will be unavailable from 7 p.m. to 11 p.m., Sunday, Dec. 3, due to scheduled maintenance. We apologize for any inconvenience." },
            new Sentence() {Text = "Frances en línea no estará disponible a partir de las 7 p.m. a 11 p.m., domingo 3 de diciembre, debido a mantenimiento programado. Pedimos disculpas por cualquier inconveniencia.\u200b"}
        };
}