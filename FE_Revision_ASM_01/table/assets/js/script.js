const users = [
  {
    id: 1,
    image: "../assets/images/avatar.png",
    name: "Nguyen Van A",
    dateCreated: "20/02/2025",
    role: "Admin",
    status: "Active",
  },
  {
    id: 2,
    image: "../assets/images/avatar.png",
    name: "Dinh Van B",
    dateCreated: "20/02/2025",
    role: "User",
    status: "Inactive",
  },
  {
    id: 3,
    image: "../assets/images/avatar.png",
    name: "Bui Van C",
    dateCreated: "20/02/2025",
    role: "User",
    status: "Suspended",
  },
];

(function () {
  window.addEventListener("load", init());

  function init() {
    const tbody = document.getElementById("tbody");
    users.forEach((user) => {
      const row = `
        <tr>
          <td>${user.id}</td>
          <td class="d-flex items-center">
            <img src="${user.image}" class="avatar" alt="avatar" />
            <span>${user.name}</span>
          </td>
          <td>${user.dateCreated}</td>
          <td>${user.role}</td>
          <td><span class="status ${
            user.status == "Active"
              ? "active"
              : user.status == "Inactive"
              ? "inactive"
              : "suspended"
          }">${user.status}</span></td>
          <td>
            <button type="button" class="button border-none transparent edit" title="Edit">
              <i class="fa fa-gear"></i>
            </button>
            <button type="button" class="button border-none transparent delete" title="Delete">
              <i class="fa fa-circle-xmark"></i>
            </button>
          </td>
        </tr>
        `;

      const tr = document.createElement("tr");
      tr.innerHTML = row;

      tbody.appendChild(tr);
    });
  }
})();
