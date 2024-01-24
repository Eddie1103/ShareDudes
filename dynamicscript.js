
document.addEventListener('DOMContentLoaded', function () {
    $.ajax({
        url: 'http://194.62.1.218:5000/getinserate',
        method: 'GET',
        dataType: 'json',
        success: function(response) {
            HandleResponse(response);
        },
        error: function(error) {
          alert(error);
        }
      });
});

function HandleResponse(data){
    var jsonData = data;

    var cardContainer = document.getElementById('cardContainer');
    cardContainer.innerHTML = '';

    for (var i = 0; i < jsonData.length; i += 2) {
        var cardRow = document.createElement('div');
        cardRow.className = 'row justify-content-center no-gutters m-2 p-1';

        var card1 = createCard(jsonData[i]);
        var col1 = createColumn(card1);
        cardRow.appendChild(col1);
        
        if (i + 1 < jsonData.length) {
            var card2 = createCard(jsonData[i + 1]);
            var col2 = createColumn(card2);
            cardRow.appendChild(col2);
        }

        cardContainer.appendChild(cardRow);
    }

    function createCard(data) {
        var card = document.createElement('div');
        card.className = 'card';
        card.id = data.id;

        var cardBody = document.createElement('div');
        cardBody.className = 'card-body d-flex flex-column';

        var cardTitle = document.createElement('h5');
        cardTitle.className = 'card-title';
        cardTitle.textContent = data.title;

        var cardText = document.createElement('p');
        cardText.className = 'card-text mb-4';
        cardText.textContent = data.text;

        var cardPic = document.createElement('img');
        cardPic.src = data.image_base64;
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
}

function loadInseratData(inseratTitle, inseratText, inseratPic) {
    var title = $("#modalTitle");
    title.text(inseratTitle);

    var text = $("#modalText");
    text.text(inseratText);

    var pic = $('#modalPic');
    pic.prop('src', inseratPic);
    console.log(inseratTitle, inseratText, inseratPic);
  }

  function getCookieValue(cookieName) 
  {
  const cookies = document.cookie;

  const cookieArray = cookies.split('; ');

  for (let i = 0; i < cookieArray.length; i++) {
      const cookie = cookieArray[i].split('=');

      if (cookie[0] === cookieName) {
          return cookie[1];
      }
  }
  
  return null;
}
