import React from "react";
import { Menu } from "../icons";

export const Header = () => {
	return (
		<header>
			<div className="header-logo">
				<h1>Clink</h1>
			</div>

			<div className="header-options-nav">
				<button>
					<Menu />
				</button>
			</div>

			<style jsx>{`
				.logoDiv,
				.optsDiv {
					border-radius: 0 0 10px 10px;
					background-color: hsl(45, 55%, 90%);
					filter: drop-shadow(0px 0px 3px hsl(0, 0%, 20%));
				}

				.header {
					height: 60px;
					display: flex;
					justify-content: space-around;
					h1 {
						margin: auto;
						font-size: 40px;
					}
				}

				.logoDiv {
					width: 300px;
				}

				.optsDiv {
					width: 300px;

					button {
						background-color: transparent;
					}

					button svg {
						width: 50px;
						fill: black;
					}
				}
			`}</style>
		</header>
	);
};
