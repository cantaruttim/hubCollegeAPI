const form = document.querySelector('#loginForm');
const apiURL = 'http://localhost:5001/api/login/auth'; // rota do seu backend .NET

form.addEventListener('submit', async (e) => {
  e.preventDefault();

  const formData = new FormData(form);
  const data = {
    registrationNumber: formData.get('matricula'), // nome do input
    password: formData.get('senha')
  };

  try {
    const response = await fetch(apiURL, {
      method: 'POST',
      headers: { 'Content-Type': 'application/json' },
      body: JSON.stringify(data)
    });

    const result = await response.json();

    if (!response.ok) {
      throw new Error(result.error || 'Usuário ou senha incorretos');
    }

    // Login bem-sucedido → redireciona
    localStorage.setItem('user', JSON.stringify(result));
    window.location.href = 'painel.html';

  } catch (error) {
    alert(error.message);
  }
});
