const activityList = document.getElementById('activity-list');
const apiURL = 'http://localhost:5001/api/formsActivity';

const fetchFActivityAPI = fetch(
    apiURL,
    {   
        method: 'GET', 
        headers: {
            'Content-Type': 'application/json'
        }
    }
).then((response) => response.json())
 .then((data) => console.log(data));

