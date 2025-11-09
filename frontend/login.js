document.addEventListener("DOMContentLoaded", () => {
  const form = document.getElementById("loginForm");

  form.addEventListener("submit", async (e) => {
    e.preventDefault();

    const matricula = form.matricula.value.trim();
    const senha = form.senha.value.trim();

    if (!matricula || !senha) {
      alert("Por favor, preencha todos os campos obrigatórios!");
      return;
    }

    try {
      const response = await fetch("http://localhost:3000/login", {
        method: "POST",
        headers: {
          "Content-Type": "application/json",
        },
        body: JSON.stringify({ matricula, senha }),
      });

      const data = await response.json();

      if (response.ok) {
        alert(`✅ Bem-vindo, ${data.nome}!`);
        // Redirecionar, se quiser:
        // window.location.href = "/dashboard.html";
      } else {
        if (data.error === "USER_NOT_FOUND") {
          if (confirm("Usuário não encontrado. Deseja se cadastrar agora?")) {
            window.location.href = "/cadastro.html";
          }
        } else {
          alert(`❌ Erro: ${data.message}`);
        }
      }
    } catch (error) {
      console.error("Erro de conexão:", error);
      alert("Erro ao conectar com o servidor. Tente novamente mais tarde.");
    }
  });
});
