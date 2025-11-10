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

// === POST ===
// Criar nova atividade
const createActivity = async (newActivity) => {
    try {
        const response = await fetch(apiURL, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(newActivity)
        });

        if (!response.ok) {
            throw new Error('Erro ao criar atividade');
        }

        const created = await response.json();
        console.log('Atividade criada com sucesso:', created);

        // Atualiza lista na tela
        getActivityList();

    } catch (error) {
        console.error(error.message);
    }
};

// === PUT ===
// Atualizar atividade existente
const updateActivity = async (id, updatedActivity) => {
    try {
        const response = await fetch(`${apiURL}/${id}`, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(updatedActivity)
        });

        if (!response.ok) {
            throw new Error('Erro ao atualizar atividade');
        }

        const updated = await response.json();
        console.log('Atividade atualizada com sucesso:', updated);

        // Atualiza lista na tela
        getActivityList();

    } catch (error) {
        console.error(error.message);
    }
};

// === DELETE ===
// Remover uma atividade
const deleteActivity = async (id) => {
    try {
        const response = await fetch(`${apiURL}/${id}`, {
            method: 'DELETE',
            headers: {
                'Content-Type': 'application/json'
            }
        });

        if (!response.ok) {
            throw new Error('Erro ao deletar atividade');
        }

        console.log(`Atividade com id ${id} deletada com sucesso`);

        // Atualiza lista na tela
        getActivityList();

    } catch (error) {
        console.error(error.message);
    }
};


// === Exemplo de uso ===

// Criar uma nova
// createActivity({ name: 'Nova atividade', description: 'Descrição...' });

// Atualizar uma existente
// updateActivity('12345', { name: 'Atividade atualizada' });

// Deletar uma atividade
// deleteActivity('12345');


getActivityList();