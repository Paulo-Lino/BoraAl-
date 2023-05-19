

let h2 = document.querySelector('h2');
var map;

function success(pos){
    console.log(pos.coords.latitude, pos.coords.longitude);
    //h2.textContent = `Latitude:${pos.coords.latitude}, Longitude:${pos.coords.longitude}`;

    if (map === undefined) {
        map = L.map('mapid').setView([pos.coords.latitude, pos.coords.longitude], 13);
    } else {
        map.remove();
        map = L.map('mapid').setView([pos.coords.latitude, pos.coords.longitude], 13);
    }

    L.tileLayer('https://{s}.tile.openstreetmap.org/{z}/{x}/{y}.png', {
        attribution: '&copy; <a href="https://www.openstreetmap.org/copyright">OpenStreetMap</a> contributors'
    }).addTo(map);

    
        L.marker([-8.06248051337705, -34.87117794026077]).addTo(map)
        .bindPopup('Marco Zero')
        .openPopup();

        L.marker([-8.06392796149065, -34.869145717173127]).addTo(map)
        .bindPopup('Torre de Cristal')
        .openPopup();

        L.marker([-8.061310442519298, -34.87150786222638]).addTo(map)
        .bindPopup('Torre Malakoff')
        .openPopup();
        
        L.marker([-8.063405, -34.871145]).addTo(map)
        .bindPopup('Cais do Sertão')
        .openPopup();

        L.marker([-8.062353, -34.874223]).addTo(map)
        .bindPopup('Igreja de São Pedro dos Clérigos')
        .openPopup();

        L.marker([-8.063531, -34.872257]).addTo(map)
        .bindPopup('Mosteiro de São Bento')
        .openPopup();


// atualizações:
// Museu da Cidade do Recife -8.062124, -34.870069
// Sinagoga Kahal Zur Israel -8.063334, -34.871962
// Teatro Apolo -8.064348, -34.874120
// Teatro Santa Isabel -8.062431, -34.874602
// Arsenal da Marinha -8.054516, -34.873416
// Forte das Cinco Pontas -8.063420, -34.877465
// Mercado de São José -8.064346, -34.879071
// Casa da Cultura -8.064633, -34.872806
// Praça da República -8.064849, -34.873746
// Palácio da Justiça -8.064161, -34.876006
// Rua do Bom Jesus -8.064324, -34.871585
// Ponte Maurício de Nassau -8.062030, -34.874860
// Pátio de São Pedro -8.062174, -34.872487
// Igreja do Divino Espírito Santo -8.063987, -34.872296
// Parque das Esculturas Francisco Brennand -8.060675, -34.860050
// Capela Dourada -8.064436, -34.873170
// Centro de Artesanato de Pernambuco -8.064776, -34.871753







L.marker([pos.coords.latitude, pos.coords.longitude]).addTo(map)
        .bindPopup('Eu estou aqui!')
        .openPopup();

     
}

function error(err){
    console.log(err);
}

var watchID = navigator.geolocation.watchPosition(success, error, {
    enableHighAccuracy: true,
    timeout: 5000
});

//navigator.geolocation.clearWatch(watchID);
