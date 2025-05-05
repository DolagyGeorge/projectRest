let orderItems = [];
let total = 0.00;
function addToOrder(product) {
    const existingItem = orderItems.find(item => item.id === product.id);

    if (existingItem) {
        existingItem.quantity += 1;
    } else {
        orderItems.push({...product, quantity: 1 });
    }

    updateOrderUI();
}

function updateOrderUI() {
    const orderList = document.getElementById('order-list');
    const subtotalElem = document.getElementById('subtotal');
    const taxElem = document.getElementById('tax');
    const totalElem = document.getElementById('total');

    orderList.innerHTML = '';

    let subtotal = 0;

    orderItems.forEach(item => {
        const itemTotal = item.price * item.quantity;
        subtotal += itemTotal;

        const listItem = document.createElement('li');
        listItem.className = 'list-group-item d-flex justify-content-between align-items-center';

        listItem.innerHTML = `
            <div>
                ${item.name} x${item.quantity}
            </div>
            <div>
                $${itemTotal.toFixed(2)}
                <button class="btn btn-sm btn-outline-secondary ms-2" onclick="decreaseQty(${item.id})">−</button>
                <button class="btn btn-sm btn-outline-secondary ms-1" onclick="increaseQty(${item.id})">+</button>
            </div>
        `;

        orderList.appendChild(listItem);
    });

    const tax = subtotal * 0.10;
    total = subtotal + tax;

    subtotalElem.textContent = subtotal.toFixed(2);
    taxElem.textContent = tax.toFixed(2);
    totalElem.textContent = total.toFixed(2);
}


function removeItem(productId) {
    orderItems = orderItems.filter(item => item.id !== productId);
    updateOrderUI();
}

function increaseQty(id) {
    const item = orderItems.find(i => i.id === id);
    if (item) {
        item.quantity += 1;
        updateOrderUI();
    }
}

function decreaseQty(id) {
    const item = orderItems.find(i => i.id === id);
    if (item) {
        item.quantity -= 1;
        if (item.quantity <= 0) {
            orderItems = orderItems.filter(i => i.id !== id);
        }
        updateOrderUI();
    }
}

document.querySelectorAll('.filter-btn').forEach(button => {
    button.addEventListener('click', () => {
        const filter = button.getAttribute('data-filter');
        document.querySelectorAll('#product-list .col-md-4').forEach(card => {
            if (card.getAttribute('data-category') === filter || filter === 'All') {
                card.style.display = 'block';
            } else {
                card.style.display = 'none';
            }
        });
    });
});

