const form = document.querySelector('#loginForm');
const apiURL = 'http://localhost:5001/api/login';

// função responsável por enviar o login
const handleLogin = async (event) => {
    event.preventDefault();

    const matricula = form.matricula.value.trim();
    const senha = form.senha.value.trim();

    if (!matricula || !senha) {
        alert('Por favor, preencha todos os campos obrigatórios!');
        return;
    }

    try {
        const response = await fetch(apiURL, {
            method: 'GET',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify({ matricula, senha })
        });

        if (!response.ok) {
            const data = await response.json();

            if (data.error === 'USER_NOT_FOUND') {
                const cadastrar = confirm('Usuário não encontrado. Deseja se cadastrar agora?');
                if (cadastrar) {
                    window.location.href = '/cadastro.html';
                }
            } else {
                alert(`❌ Erro: ${data.message}`);
            }
            return;
        }

        const data = await response.json();
        alert(`✅ Bem-vindo, ${data.nome}!`);
        // Redirecionar se necessário
        // window.location.href = "/dashboard.html";

    } catch (error) {
        console.error('Erro de conexão:', error);
        alert('Erro ao conectar com o servidor. Tente novamente mais tarde.');
    }
};

// adiciona o event listener do formulário
form.addEventListener('submit', handleLogin);
