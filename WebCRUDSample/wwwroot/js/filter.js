    let sortOrder = {};

    function sortTable(columnIndex) {
        const table = document.querySelector('.table');
        const tbody = table.querySelector('tbody');
        const rows = Array.from(tbody.querySelectorAll('tr'));

        // Toggle sort order
        sortOrder[columnIndex] = !sortOrder[columnIndex];
        const order = sortOrder[columnIndex] ? 'asc' : 'desc';

        // Update sort indicator
        const headers = table.querySelectorAll('th');
        headers.forEach((header, index) => {
            const indicator = header.querySelector('.sort-indicator');
            if (indicator) {
                if (index === columnIndex) {
                    indicator.textContent = order === 'asc' ? '↑' : '↓';
                } else {
                    indicator.textContent = '';
                }
            }
        });

        // Sort rows
        rows.sort((a, b) => {
            const cellA = a.cells[columnIndex].textContent.trim().toLowerCase();
            const cellB = b.cells[columnIndex].textContent.trim().toLowerCase();

            if (!isNaN(cellA) && !isNaN(cellB)) {
                return order === 'asc' ? cellA - cellB : cellB - cellA;
            } else {
                return order === 'asc' ? cellA.localeCompare(cellB) : cellB.localeCompare(cellA);
            }
        });

        // Append sorted rows to tbody
        rows.forEach(row => tbody.appendChild(row));
    }

    function filterTable(columnIndex) {
        const input = event.target.value.toLowerCase();
        const table = document.querySelector('.table');
        const rows = table.querySelectorAll('tbody tr');

        rows.forEach(row => {
            const cell = row.cells[columnIndex];
            if (cell) {
                const text = cell.textContent || cell.innerText;
                row.style.display = text.toLowerCase().includes(input) ? '' : 'none';
            }
        });
    }