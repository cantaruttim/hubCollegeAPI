console.log("Script loaded successfully.");


const fetchFActivityAPI = fetch(
    'http://localhost:5001/api/formsActivity',
    {   
        method: 'GET',
        'Content-Type': 'application/json'
    }
);

console.log(fetchFActivityAPI);