
document.addEventListener('DOMContentLoaded', function () {
    var jsonData = [
        {
            title: "Habe Rouladen übrig!",
            text: "Habe eine größere Portion gekocht aber der Hunger war größer als der Magen, würde so 3 Stück abgegeben!",
            pic: "https://bbq-piraten.de/community/data/attachments/351/351068-07b61497a93c18894bdb5a9aa675b686.jpg"
        },
        {
            title: "Waschmaschine zu verleihen",
            text: "Hallo, ich würde gerne meine Waschmaschine zur Verfügung stellen während ich im Urlaub bin, einfach anfragen!",
            pic: "https://img.kleinanzeigen.de/api/v1/prod-ads/images/e2/e27767ff-fadb-4430-9d68-c9beec8f9ecf?rule=$_59.JPG"
        },
        {
            title: "Gartenbeet frei!",
            text: "Hallihallo, habe in meinem Garten noch ein Beet frei, zuletzt waren dort Tomaten gepflanzt aber dieses Jahr habe ich keine Lust. Wenn jemand an diesem Platz anpflanzen möchte einfach melden!",
            pic: "https://upload.wikimedia.org/wikipedia/commons/a/ab/Schrebergarten_1.jpg"
        },
        {
            title: "Linus brauch einen Aufpasser",
            text: "Hey Community, mein Hund Linus ist eine Woche auf sich allein gestellt da ich im Urlaub bin, bevor ich Angehörige nerve, frage ich ob sich hier vielleicht jemand findet! Mehr Infos nach Anfrage.",
            pic: "https://www.zooroyal.de/magazin/wp-content/uploads/2017/08/hund-in-der-spaziergang-760x570.jpg"
        },
        {
            title: "Verschenke rostige Mühle",
            text: "Kein Bock mehr auf das Fahrrad in meinem Keller, steht nur rum und nimmt Platz weg. Wer es gerne haben möchte meldet sich.",
            pic: "https://cdn.germanscooterforum.de/monthly_04_2008/post-5890-1207589007_thumb.jpg"
        },
        {
            title: "Alte Musikanlage kaputt",
            text: "Meine alte Stereoanlage macht Probleme, kann jemand mit Kentnissen mir helfen? Entlohnung folgt Selbstverständlich.",
            pic: "https://light-microscope.net/wp-content/uploads/2019/05/Steroanlage.jpg"
        }
    ];


    // Container für die Bootstrap-Karten
    var cardContainer = document.getElementById('cardContainer');

    cardContainer.innerHTML = '';


    // Schleife durch das JSON-Array und erstelle Bootstrap-Karten in Gruppen von je zwei Karten
    for (var i = 0; i < jsonData.length; i += 2) {
        // Bootstrap-Row für jede Gruppe von Karten
        var cardRow = document.createElement('div');
        cardRow.className = 'row justify-content-center no-gutters m-2 p-1';

        // Erste Karte in der Gruppe
        var card1 = createCard(jsonData[i], i);
        var col1 = createColumn(card1);
        cardRow.appendChild(col1);

        // Überprüfen, ob es eine zweite Karte in der Gruppe gibt
        if (i + 1 < jsonData.length) {
            // Zweite Karte in der Gruppe
            var card2 = createCard(jsonData[i + 1], i+1);
            var col2 = createColumn(card2);
            cardRow.appendChild(col2);
        }

        // Füge die Bootstrap-Row zum Container hinzu
        cardContainer.appendChild(cardRow);
    }

    // Funktion zum Erstellen einer Bootstrap-Karte
    function createCard(data, index) {
        var card = document.createElement('div');
        card.className = 'card';

        var cardBody = document.createElement('div');
        cardBody.className = 'card-body d-flex flex-column';

        var cardTitle = document.createElement('h5');
        cardTitle.className = 'card-title';
        cardTitle.textContent = data.title;

        var cardText = document.createElement('p');
        cardText.className = 'card-text mb-4';
        cardText.textContent = data.text;

        var cardPic = document.createElement('img');
        cardPic.src = data.pic;
        cardPic.classname = 'card-img-top';

        var cardButton = document.createElement('a');
        cardButton.className = 'btn btn-primary stretched-link';
        cardButton.innerText = 'Zur Anzeige';
        cardButton.setAttribute('data-toggle', 'modal');
        cardButton.setAttribute('data-target', '#showModal');

        cardBody.onclick = function(){ loadInseratData(data.title, data.text, data.pic) };

        cardBody.appendChild(cardTitle);
        cardBody.appendChild(cardText);
        cardBody.appendChild(cardButton);
        card.appendChild(cardPic);
        card.appendChild(cardBody);

        return card;
    }

    // Funktion zum Erstellen einer Bootstrap-Column
    function createColumn(card) {
        var col = document.createElement('div');
        col.className = 'col-lg-4 mb-3 mx-3 d-flex align-items-stretch';
        col.appendChild(card);
        return col;
    }
});

function loadInseratData(inseratTitle, inseratText, inseratPic) {
    var title = $("#modalTitle");
    title.text(inseratTitle);

    var text = $("#modalText");
    text.text(inseratText);

    var pic = $('#modalPic');
    pic.prop('src', inseratPic);
    console.log(inseratTitle, inseratText, inseratPic);
  }

