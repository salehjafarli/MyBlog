<template>
    <ul class="pagination">
        <li class="page-item">
            <a class="page-link" @click="onPageBack">
                <i class="fa fa-arrow-left" ></i>
            </a>
        </li>

        <template v-for="(i, y) in pages">
            <li v-if="y < maxVisible" :key="'pagination-page-' + i" :class="{ 'page-item': 1, active: value == i }">
                <a class="page-link" @click="onPageClick(i)">{{ i }}</a>
            </li>
        </template>

        <li class="page-item" >
            <a class="page-link" @click="onPageForward">
                <i class="fa fa-arrow-right"></i>
            </a>
        </li>
    </ul>
</template>

<script>
export default {
    props: {
        value: {
            type: Number,
            default: () => 1,
        },
        rowsNumber: {
            type: Number,
            default: () => 0,
        },
        rowsPerPage: {
            type: Number,
            default: () => 0,
        },
        maxVisible: {
            // Max buttons in a row
            type: Number,
            default: () => 5,
        }

    },
    computed: {
        pages() {
            function range(start, end) {
                return Array.from(Array(end - start + 1), (_, i) => i + start);
            }

            const max = this.maxVisible;
            const middle = Math.floor(this.maxVisible / 2);
            const pageNum = Math.ceil(this.rowsNumber / this.rowsPerPage);

            if (pageNum < max) {
                return range(1, pageNum);
            }

            let start = this.value - middle;
            let end = this.value + middle;

            // If we're close to the end
            if (this.value >= pageNum - middle) {
                start = pageNum - max + 1;
                end = pageNum;
            }

            return range(Math.max(1, start), Math.max(end, max));
        },
    },
    methods: {
        onPageClick(page) {
            this.$emit('update:value', page);
        },
        onPageBack() {
            if (this.value - 1 >= 1) {
                this.onPageClick(this.value - 1);
            }
        },
        onPageForward() {
            if (
                this.value + 1 <=
                Math.ceil(this.rowsNumber / this.rowsPerPage)
            ){
                this.onPageClick(this.value + 1);
            }
        },
    }
}
</script>

<style>
ul.pagination {
	display: flex;
	padding-left: 0;
	list-style: none;
	border-radius: 0.25rem;
}
ul.pagination li.page-item {
	line-height: 24px;
	margin-right: 0.5rem;
}
ul.pagination li.page-item a.page-link {
	padding: 0;
	width: 40px;
	height: 40px;
	display: block;
	font-size: 1rem;
    font-weight: 600;
	line-height: 40px;
	user-select: none;
	position: relative;
	text-align: center;
	border-radius: 50%;
	border: 2px solid var(--secondary-color);
	box-sizing: content-box;
	background: transparent;
}
ul.pagination li.page-item.active > a.page-link, ul.pagination li.page-item > a.page-link:hover {
	color: black;
	cursor: pointer;
	border-color: var(--secondary-color);
	background-color: var(--secondary-color);
}
</style>