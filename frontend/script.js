const activityList = document.querySelector('.activities-list');
const apiURL = 'http://localhost:5001/api/formsActivity';

// get student information from backend
const getActivityList = async () => {
    try {
        const response = await fetch(
            apiURL,
            {
                method: 'GET',
                headers: {
                    'Content-Type': 'application/json'
                }
            }
        );
        if (!response.ok) {
            throw new Error('Erro while fetching activity list');
        }

        const activities = await response.json();

        activities.forEach( (activity) => {
            const newLi = document.createElement('li');
            newLi.innerText = `Student: ${activity.name}`;
            activityList.appendChild(newLi);
        })

    } catch (error) {
        console.error(error.message);
    }
}




getActivityList();