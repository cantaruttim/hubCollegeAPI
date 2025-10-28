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
    } catch (error) {
        console.error('Error fetching activity list:', error);
    }
}
