
mapboxgl.accessToken = 'pk.eyJ1IjoicmFmYWVsdmF2YSIsImEiOiJjbGkwcHFvaWIxZ3R5M2hwOXF0ZmxucmZvIn0.eKHsXwyf3AlkjMVvnf4PJg';

function getCurrentLocation() {
    if (navigator.geolocation) {
        navigator.geolocation.getCurrentPosition(showPosition);
    } else {
        alert('Geolocation is not supported by this browser.');
    }
}

function showPosition(position) {
    const latitude = position.coords.latitude;
    const longitude = position.coords.longitude;

   
    initMap(latitude, longitude);
}


function initMap(latitude, longitude) {
    const map = new mapboxgl.Map({
        container: 'mapid',
        style: 'mapbox://styles/mapbox/streets-v11',
        center: [longitude, latitude], // Coordenadas iniciais
        zoom: 12
        

    });
    const userMarker = new mapboxgl.Marker()
    .setLngLat([longitude, latitude])
    .addTo(map); 
    
    const points = document.querySelectorAll('#points input');
    const markers = [];

    points.forEach(point => {
        point.addEventListener('change', function () {
            const isChecked = this.checked;
            const value = this.value;

            if (isChecked) {
                const coordinates = getCoordinates(value);
                const marker = new mapboxgl.Marker()
                    .setLngLat(coordinates)
                    .addTo(map);
                markers.push(marker);
            } else {
                const markerIndex = markers.findIndex(marker => marker.getLngLat().equals(getCoordinates(value)));
                if (markerIndex !== -1) {
                    markers[markerIndex].remove();
                    markers.splice(markerIndex, 1);
                }
            }
        });
    });

    const calculateRouteBtn = document.getElementById('calculate-route-btn');
    calculateRouteBtn.addEventListener('click', function () {
        const selectedPoints = Array.from(points)
            .filter(point => point.checked)
            .map(point => point.value);

        if (selectedPoints.length < 1) {
            alert('Selecione pelo menos um ponto para calcular a rota.');
            return;
        }

        const startPoint = [longitude, latitude]; // Coordenadas do ponto de partida
        const endPoint = getCoordinates(selectedPoints[selectedPoints.length - 1]);

        const directionsAPI = `https://api.mapbox.com/directions/v5/mapbox/walking/${startPoint[0]},${startPoint[1]};${endPoint[0]},${endPoint[1]}?geometries=geojson&access_token=${mapboxgl.accessToken}`;

        fetch(directionsAPI)
            .then(response => response.json())
            .then(data => {
                const route = data.routes[0].geometry;

                if (map.getSource('route')) {
                    map.getSource('route').setData({
                        type: 'Feature',
                        properties: {},
                        geometry: route
                    });
                } else {
                    map.addSource('route', {
                        type: 'geojson',
                        data: {
                            type: 'Feature',
                            properties: {},
                            geometry: route
                        }
                    });

                    map.addLayer({
                        id: 'route',
                        type: 'line',
                        source: 'route',
                        layout: {
                            'line-join': 'round',
                            'line-cap': 'round'
                        },
                        paint: {
                            'line-color': '#900',
                            'line-width': 6
                        }
                    });
                }

                const bounds = new mapboxgl.LngLatBounds();
                bounds.extend(startPoint);
                bounds.extend(endPoint);
                map.fitBounds(bounds, { padding: 100 });
            });
    });
}

function getCoordinates(pointName) {
    switch (pointName) {
        case 'Marco Zero':
            return [-34.87117794026077, -8.06248051337705];
        case 'Torre de Cristal':
            return [-34.869145717173127, -8.06392796149065];
        case 'Torre Malakoff':
            return [-34.87150786222638, -8.061310442519298];
        case 'Cais do Sertão':
            return [-34.871145, -8.063405];
        case 'Igreja de São Pedro dos Clérigos':
            return [-34.874223, -8.062353];
        case 'Mosteiro de São Bento':
            return [-34.870588, -8.063531];
        default:
            return [0, 0];
    }
}

getCurrentLocation();

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




