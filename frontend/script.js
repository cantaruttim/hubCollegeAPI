const activityList = document.getElementById('activity-list');

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

