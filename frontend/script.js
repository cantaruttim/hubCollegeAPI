console.log("Script loaded successfully.");


const fetchFActivityAPI = fetch(
    'http://localhost:5001/api/formsActivity',
    {   
        method: 'GET', 
        headers: {
            'Content-Type': 'application/json'
        }
    }
).then((response) => response.json())
 .then((data) => console.log(data));

