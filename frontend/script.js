const activityList = document.getElementById('activity-list');
const apiURL = 'http://localhost:5001/api/formsActivity';


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

        activities.foreach( (activity) => {
            const newLi = document.createElement('li');
            newLi.innerText = `Student: ${activity.nome}`;
            activitiesList.appendChild(newLi);
        })

    } catch (error) {
        console.error(error);
    }
}

getActivityList();